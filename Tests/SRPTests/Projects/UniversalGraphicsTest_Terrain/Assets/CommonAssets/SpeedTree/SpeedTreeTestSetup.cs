using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


public class SpeedTreeTestSetup : MonoBehaviour
{
    void OnEnable()
    {
        if (GraphicsSettings.defaultRenderPipeline != null)
        {
            var lwAsset = (UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset)GraphicsSettings.defaultRenderPipeline;
            distance = lwAsset.shadowDistance;
            lwAsset.shadowDistance = 1000.0f;
            lodBias = QualitySettings.lodBias;
            QualitySettings.lodBias = 1.0f;
        }
    }

    void OnDisable()
    {
        if (GraphicsSettings.defaultRenderPipeline != null)
        {
            var lwAsset = (UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset)GraphicsSettings.defaultRenderPipeline;
            lwAsset.shadowDistance = distance;
            QualitySettings.lodBias = lodBias;
        }
    }

    float distance = 0.0f;
    float lodBias = 1.0f;
}
