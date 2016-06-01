﻿namespace CubeWorld.Artifacts
{
    public interface IArtifactGraphics
    {

        void SetArtifact(Artifact artifact);

        void UpdateMesh();
        void UpdateAmbientLight();

    }
}
