//Neonatal
//Don Xu
//Blend shader script
//version 1.0

Shader "Custom/testShader" {
Properties {
_MainTex ("Texture1", 2D) = "white" {}
_Texture2 ("Texture2", 2D) = "" {}
_Blend ("Blend", Range(0,1)) = 0.5
}

SubShader {
    Tags {"Queue"="Transparent" "IgnoreProjector"="True"}
    //ZWrite Off
    //Blend One One
    Pass{
        SetTexture[_MainTex]
        SetTexture[_Texture2]{
            ConstantColor (1,0,0, [_Blend])
            Combine texture Lerp(constant) previous
        }
    }

} 
}