
//-----------------------------------------------------------------------------
// structure definition
//-----------------------------------------------------------------------------
namespace UnityEngine.Experimental.Rendering.HDPipeline
{
    namespace Text
    {
        //-----------------------------------------------------------------------------
        // SurfaceData
        //-----------------------------------------------------------------------------

        // Main structure that store the user data (i.e user input of master node in material graph)
        [GenerateHLSL(PackingRules.Exact, false, true, false,1100)]
        public struct SurfaceData
        {
            [SurfaceDataAttributes("Color")]
            public Vector3 color;
        };

        //-----------------------------------------------------------------------------
        // BSDFData
        //-----------------------------------------------------------------------------
        [GenerateHLSL(PackingRules.Exact, false, true, false, 1130)]
        public struct BSDFData
        {
            public Vector3 color;
        };
    }
}
