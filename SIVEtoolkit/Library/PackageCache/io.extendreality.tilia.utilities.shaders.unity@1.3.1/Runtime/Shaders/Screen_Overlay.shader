// UNITY_SHADER_NO_UPGRADE
Shader "Tilia/Screen/Overlay"
{
	Properties
	{
		_Color("Color Tint", Color) = (1,1,1,1)
		_MainTex("Base (RGB) Alpha (A)", 2D) = "white"
	}

		SubShader
	{
		Lighting Off
		ZTest Off
		Cull back
		Blend SrcAlpha OneMinusSrcAlpha
		Tags{ Queue = Transparent }

		Pass
		{
			CGPROGRAM
				#pragma vertex vert
				#pragma fragment frag

				#include "UnityCG.cginc"

				struct data
				{
					float4 pos : POSITION;
					float2 coord : TEXCOORD0;
					fixed4 color : COLOR;

					UNITY_VERTEX_INPUT_INSTANCE_ID
				};

				struct vert2frag
				{
					float4 pos : SV_POSITION;
					half2 coord : TEXCOORD0;
					fixed4 color : COLOR;

					UNITY_VERTEX_OUTPUT_STEREO
				};

				sampler2D _MainTex;
				float4 _MainTex_ST;
				fixed4 _Color;

				vert2frag vert(data input)
				{
					vert2frag result;

					UNITY_SETUP_INSTANCE_ID(input);
					UNITY_INITIALIZE_OUTPUT(vert2frag, result);
					UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(result);

					result.pos = UnityObjectToClipPos(input.pos);
					result.pos.z -= 0.01;
					result.coord = TRANSFORM_TEX(input.coord, _MainTex);
					result.color = input.color;
					return result;
				}

				fixed4 frag(vert2frag input) : COLOR
				{
					fixed4 result = tex2D(_MainTex, input.coord) * input.color * _Color;
					return result;
				}
			ENDCG
		}
	}
}
