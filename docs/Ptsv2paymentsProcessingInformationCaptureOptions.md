# CyberSource.Model.Ptsv2paymentsProcessingInformationCaptureOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CaptureSequenceNumber** | **decimal?** | Capture number when requesting multiple partial captures for one authorization. Used along with &#x60;totalCaptureCount&#x60; to track which capture is being processed.  For example, the second of five captures would be passed to CyberSource as:   - &#x60;captureSequenceNumber_ &#x3D; 2&#x60;, and   - &#x60;totalCaptureCount &#x3D; 5&#x60;  | [optional] 
**TotalCaptureCount** | **decimal?** | Total number of captures when requesting multiple partial captures for one payment. Used along with &#x60;captureSequenceNumber&#x60; field to track which capture is being processed.  For example, the second of five captures would be passed to CyberSource as:   - &#x60;captureSequenceNumber &#x3D; 2&#x60;, and   - &#x60;totalCaptureCount &#x3D; 5&#x60;  | [optional] 
**DateToCapture** | **string** | Date on which you want the capture to occur. This field is supported only for Visa Platform Connect.\\ &#x60;Format: MMDD&#x60;  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

