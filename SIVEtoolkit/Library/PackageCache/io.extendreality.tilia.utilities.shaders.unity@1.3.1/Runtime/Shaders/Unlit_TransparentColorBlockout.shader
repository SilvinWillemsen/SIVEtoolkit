// UNITY_SHADER_NO_UPGRADE
Shader "Tilia/Unlit/TransparentColorBlockout"
{
	Properties
	{
		_Color("Main Color", Color) = (1,1,1,1)
	}

		SubShader
	{
		Tags { "Queue" = "Transparent" "IgnoreProjector" = "True" "RenderType" = "Transparent" }
		LOD 100
		Fog { Mode Off }
		ZTest Always
		Blend SrcAlpha OneMinusSrcAlpha
		Color[_Color]
		Pass {}
	}
}