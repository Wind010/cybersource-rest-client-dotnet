/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITransactionBatchesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get individual batch file
        /// </summary>
        /// <remarks>
        /// Provide the search range
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The batch id assigned for the template.</param>
        /// <returns>PtsV1TransactionBatchesIdGet200Response</returns>
        PtsV1TransactionBatchesIdGet200Response GetTransactionBatchId (string id);

        /// <summary>
        /// Get individual batch file
        /// </summary>
        /// <remarks>
        /// Provide the search range
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The batch id assigned for the template.</param>
        /// <returns>ApiResponse of PtsV1TransactionBatchesIdGet200Response</returns>
        ApiResponse<PtsV1TransactionBatchesIdGet200Response> GetTransactionBatchIdWithHttpInfo (string id);
        /// <summary>
        /// Get a list of batch files
        /// </summary>
        /// <remarks>
        /// Provide the search range
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </param>
        /// <returns>PtsV1TransactionBatchesGet200Response</returns>
        PtsV1TransactionBatchesGet200Response GetTransactionBatches (DateTime? startTime, DateTime? endTime);

        /// <summary>
        /// Get a list of batch files
        /// </summary>
        /// <remarks>
        /// Provide the search range
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </param>
        /// <returns>ApiResponse of PtsV1TransactionBatchesGet200Response</returns>
        ApiResponse<PtsV1TransactionBatchesGet200Response> GetTransactionBatchesWithHttpInfo (DateTime? startTime, DateTime? endTime);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get individual batch file
        /// </summary>
        /// <remarks>
        /// Provide the search range
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The batch id assigned for the template.</param>
        /// <returns>Task of PtsV1TransactionBatchesIdGet200Response</returns>
        System.Threading.Tasks.Task<PtsV1TransactionBatchesIdGet200Response> GetTransactionBatchIdAsync (string id);

        /// <summary>
        /// Get individual batch file
        /// </summary>
        /// <remarks>
        /// Provide the search range
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The batch id assigned for the template.</param>
        /// <returns>Task of ApiResponse (PtsV1TransactionBatchesIdGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PtsV1TransactionBatchesIdGet200Response>> GetTransactionBatchIdAsyncWithHttpInfo (string id);
        /// <summary>
        /// Get a list of batch files
        /// </summary>
        /// <remarks>
        /// Provide the search range
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </param>
        /// <returns>Task of PtsV1TransactionBatchesGet200Response</returns>
        System.Threading.Tasks.Task<PtsV1TransactionBatchesGet200Response> GetTransactionBatchesAsync (DateTime? startTime, DateTime? endTime);

        /// <summary>
        /// Get a list of batch files
        /// </summary>
        /// <remarks>
        /// Provide the search range
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </param>
        /// <returns>Task of ApiResponse (PtsV1TransactionBatchesGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PtsV1TransactionBatchesGet200Response>> GetTransactionBatchesAsyncWithHttpInfo (DateTime? startTime, DateTime? endTime);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TransactionBatchesApi : ITransactionBatchesApi
    {
        private CyberSource.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionBatchesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransactionBatchesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = CyberSource.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionBatchesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TransactionBatchesApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = CyberSource.Client.Configuration.DefaultExceptionFactory;

            this.Configuration.ApiClient.Configuration = this.Configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public CyberSource.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get individual batch file Provide the search range
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The batch id assigned for the template.</param>
        /// <returns>PtsV1TransactionBatchesIdGet200Response</returns>
        public PtsV1TransactionBatchesIdGet200Response GetTransactionBatchId (string id)
        {
             ApiResponse<PtsV1TransactionBatchesIdGet200Response> localVarResponse = GetTransactionBatchIdWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get individual batch file Provide the search range
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The batch id assigned for the template.</param>
        /// <returns>ApiResponse of PtsV1TransactionBatchesIdGet200Response</returns>
        public ApiResponse< PtsV1TransactionBatchesIdGet200Response > GetTransactionBatchIdWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionBatchesApi->GetTransactionBatchId");

            var localVarPath = $"/pts/v1/transaction-batches/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/hal+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTransactionBatchId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PtsV1TransactionBatchesIdGet200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV1TransactionBatchesIdGet200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV1TransactionBatchesIdGet200Response)));
        }

        /// <summary>
        /// Get individual batch file Provide the search range
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The batch id assigned for the template.</param>
        /// <returns>Task of PtsV1TransactionBatchesIdGet200Response</returns>
        public async System.Threading.Tasks.Task<PtsV1TransactionBatchesIdGet200Response> GetTransactionBatchIdAsync (string id)
        {
             ApiResponse<PtsV1TransactionBatchesIdGet200Response> localVarResponse = await GetTransactionBatchIdAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get individual batch file Provide the search range
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The batch id assigned for the template.</param>
        /// <returns>Task of ApiResponse (PtsV1TransactionBatchesIdGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PtsV1TransactionBatchesIdGet200Response>> GetTransactionBatchIdAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionBatchesApi->GetTransactionBatchId");

            var localVarPath = $"/pts/v1/transaction-batches/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/hal+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTransactionBatchId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PtsV1TransactionBatchesIdGet200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV1TransactionBatchesIdGet200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV1TransactionBatchesIdGet200Response)));
        }

        /// <summary>
        /// Get a list of batch files Provide the search range
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </param>
        /// <returns>PtsV1TransactionBatchesGet200Response</returns>
        public PtsV1TransactionBatchesGet200Response GetTransactionBatches (DateTime? startTime, DateTime? endTime)
        {
             ApiResponse<PtsV1TransactionBatchesGet200Response> localVarResponse = GetTransactionBatchesWithHttpInfo(startTime, endTime);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of batch files Provide the search range
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </param>
        /// <returns>ApiResponse of PtsV1TransactionBatchesGet200Response</returns>
        public ApiResponse< PtsV1TransactionBatchesGet200Response > GetTransactionBatchesWithHttpInfo (DateTime? startTime, DateTime? endTime)
        {
            // verify the required parameter 'startTime' is set
            if (startTime == null)
                throw new ApiException(400, "Missing required parameter 'startTime' when calling TransactionBatchesApi->GetTransactionBatches");
            // verify the required parameter 'endTime' is set
            if (endTime == null)
                throw new ApiException(400, "Missing required parameter 'endTime' when calling TransactionBatchesApi->GetTransactionBatches");

            var localVarPath = $"/pts/v1/transaction-batches?startTime={startTime.Value.ToString("yyyy-MM-ddTHH:mm:ssZ")}&endTime={endTime.Value.ToString("yyyy-MM-ddTHH:mm:ssZ")}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/hal+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            //if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            //if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTransactionBatches", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PtsV1TransactionBatchesGet200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV1TransactionBatchesGet200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV1TransactionBatchesGet200Response)));
        }

        /// <summary>
        /// Get a list of batch files Provide the search range
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </param>
        /// <returns>Task of PtsV1TransactionBatchesGet200Response</returns>
        public async System.Threading.Tasks.Task<PtsV1TransactionBatchesGet200Response> GetTransactionBatchesAsync (DateTime? startTime, DateTime? endTime)
        {
             ApiResponse<PtsV1TransactionBatchesGet200Response> localVarResponse = await GetTransactionBatchesAsyncWithHttpInfo(startTime, endTime);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of batch files Provide the search range
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZZ </param>
        /// <returns>Task of ApiResponse (PtsV1TransactionBatchesGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PtsV1TransactionBatchesGet200Response>> GetTransactionBatchesAsyncWithHttpInfo (DateTime? startTime, DateTime? endTime)
        {
            // verify the required parameter 'startTime' is set
            if (startTime == null)
                throw new ApiException(400, "Missing required parameter 'startTime' when calling TransactionBatchesApi->GetTransactionBatches");
            // verify the required parameter 'endTime' is set
            if (endTime == null)
                throw new ApiException(400, "Missing required parameter 'endTime' when calling TransactionBatchesApi->GetTransactionBatches");

            var localVarPath = $"/pts/v1/transaction-batches?startTime={startTime.Value.ToString("yyyy-MM-ddTHH:mm:ssZ")}&endTime={endTime.Value.ToString("yyyy-MM-ddTHH:mm:ssZ")}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/hal+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            //if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            //if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTransactionBatches", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PtsV1TransactionBatchesGet200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV1TransactionBatchesGet200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV1TransactionBatchesGet200Response)));
        }

    }
}
