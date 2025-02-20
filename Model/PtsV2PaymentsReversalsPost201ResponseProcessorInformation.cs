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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// PtsV2PaymentsReversalsPost201ResponseProcessorInformation
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsReversalsPost201ResponseProcessorInformation :  IEquatable<PtsV2PaymentsReversalsPost201ResponseProcessorInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsReversalsPost201ResponseProcessorInformation" /> class.
        /// </summary>
        /// <param name="TransactionId">Processor transaction ID.  This value identifies the transaction on a host system. This value is supported only for Moneris. It contains this information:   - Terminal used to process the transaction  - Shift during which the transaction took place  - Batch number  - Transaction number within the batch  You must store this value. If you give the customer a receipt, display this value on the receipt.  Example For the value 66012345001069003:   - Terminal ID &#x3D; 66012345  - Shift number &#x3D; 001  - Batch number &#x3D; 069  - Transaction number &#x3D; 003 .</param>
        /// <param name="ResponseCode">For most processors, this is the error message sent directly from the bank. Returned only when the processor returns this value.  **Important** Do not use this field to evaluate the result of the authorization.  #### AIBMS If this value is &#x60;08&#x60;, you can accept the transaction if the customer provides you with identification.  #### Atos This value is the response code sent from Atos and it might also include the response code from the bank. Format: &#x60;aa,bb&#x60; with the two values separated by a comma and where: - &#x60;aa&#x60; is the two-digit error message from Atos. - &#x60;bb&#x60; is the optional two-digit error message from the bank.  #### Comercio Latino This value is the status code and the error or response code received from the processor separated by a colon. Format: [status code]:E[error code] or [status code]:R[response code] Example &#x60;2:R06&#x60;  #### JCN Gateway Processor-defined detail error code. The associated response category code is in the &#x60;responseCategoryCode&#x60; field. .</param>
        /// <param name="ResponseCategoryCode">Processor-defined response category code. The associated detail error code is in the &#x60;responseCode&#x60; field of the service you requested.  This field is supported only for:   - Japanese issuers  - Domestic transactions in Japan  - Comercio Latino—processor transaction ID required for troubleshooting  **Maximum length for processors**:   - Comercio Latino: 32  - All other processors: 3 .</param>
        /// <param name="ForwardedAcquirerCode">Name of the Japanese acquirer that processed the transaction. Returned only for JCN Gateway. Please contact the CyberSource Japan Support Group for more information. .</param>
        /// <param name="MasterCardServiceCode">Mastercard service that was used for the transaction. Mastercard provides this value to CyberSource.  Possible value:  - 53: Mastercard card-on-file token service  #### Visa Platform Connect The value for this field corresponds to the following data in the TC 33 capture file: - Record: CP01 TCR6 - Position: 133-134 - Field: Mastercard Merchant on-behalf service. **Note** This field is returned only for Visa Platform Connect. .</param>
        /// <param name="MasterCardServiceReplyCode">Result of the Mastercard card-on-file token service. Mastercard provides this value to CyberSource.  Possible values:   - &#x60;C&#x60;: Service completed successfully.  - &#x60;F&#x60;: One of the following:    - Incorrect Mastercard POS entry mode. The Mastercard POS entry mode should be 81 for an authorization or      authorization reversal.    - Incorrect Mastercard POS entry mode. The Mastercard POS entry mode should be 01 for a tokenized request.    - Token requestor ID is missing or formatted incorrectly.  - &#x60;I&#x60;: One of the following:    - Invalid token requestor ID.    - Suspended or deactivated token.    - Invalid token (not in mapping table).  - &#x60;T&#x60;: Invalid combination of token requestor ID and token.  - &#x60;U&#x60;: Expired token.  - &#x60;W&#x60;: Primary account number (PAN) listed in electronic warning bulletin.  **Note** This field is returned only for **Visa Platform Connect**. .</param>
        public PtsV2PaymentsReversalsPost201ResponseProcessorInformation(string TransactionId = default(string), string ResponseCode = default(string), string ResponseCategoryCode = default(string), string ForwardedAcquirerCode = default(string), string MasterCardServiceCode = default(string), string MasterCardServiceReplyCode = default(string))
        {
            this.TransactionId = TransactionId;
            this.ResponseCode = ResponseCode;
            this.ResponseCategoryCode = ResponseCategoryCode;
            this.ForwardedAcquirerCode = ForwardedAcquirerCode;
            this.MasterCardServiceCode = MasterCardServiceCode;
            this.MasterCardServiceReplyCode = MasterCardServiceReplyCode;
        }
        
        /// <summary>
        /// Processor transaction ID.  This value identifies the transaction on a host system. This value is supported only for Moneris. It contains this information:   - Terminal used to process the transaction  - Shift during which the transaction took place  - Batch number  - Transaction number within the batch  You must store this value. If you give the customer a receipt, display this value on the receipt.  Example For the value 66012345001069003:   - Terminal ID &#x3D; 66012345  - Shift number &#x3D; 001  - Batch number &#x3D; 069  - Transaction number &#x3D; 003 
        /// </summary>
        /// <value>Processor transaction ID.  This value identifies the transaction on a host system. This value is supported only for Moneris. It contains this information:   - Terminal used to process the transaction  - Shift during which the transaction took place  - Batch number  - Transaction number within the batch  You must store this value. If you give the customer a receipt, display this value on the receipt.  Example For the value 66012345001069003:   - Terminal ID &#x3D; 66012345  - Shift number &#x3D; 001  - Batch number &#x3D; 069  - Transaction number &#x3D; 003 </value>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// For most processors, this is the error message sent directly from the bank. Returned only when the processor returns this value.  **Important** Do not use this field to evaluate the result of the authorization.  #### AIBMS If this value is &#x60;08&#x60;, you can accept the transaction if the customer provides you with identification.  #### Atos This value is the response code sent from Atos and it might also include the response code from the bank. Format: &#x60;aa,bb&#x60; with the two values separated by a comma and where: - &#x60;aa&#x60; is the two-digit error message from Atos. - &#x60;bb&#x60; is the optional two-digit error message from the bank.  #### Comercio Latino This value is the status code and the error or response code received from the processor separated by a colon. Format: [status code]:E[error code] or [status code]:R[response code] Example &#x60;2:R06&#x60;  #### JCN Gateway Processor-defined detail error code. The associated response category code is in the &#x60;responseCategoryCode&#x60; field. 
        /// </summary>
        /// <value>For most processors, this is the error message sent directly from the bank. Returned only when the processor returns this value.  **Important** Do not use this field to evaluate the result of the authorization.  #### AIBMS If this value is &#x60;08&#x60;, you can accept the transaction if the customer provides you with identification.  #### Atos This value is the response code sent from Atos and it might also include the response code from the bank. Format: &#x60;aa,bb&#x60; with the two values separated by a comma and where: - &#x60;aa&#x60; is the two-digit error message from Atos. - &#x60;bb&#x60; is the optional two-digit error message from the bank.  #### Comercio Latino This value is the status code and the error or response code received from the processor separated by a colon. Format: [status code]:E[error code] or [status code]:R[response code] Example &#x60;2:R06&#x60;  #### JCN Gateway Processor-defined detail error code. The associated response category code is in the &#x60;responseCategoryCode&#x60; field. </value>
        [DataMember(Name="responseCode", EmitDefaultValue=false)]
        public string ResponseCode { get; set; }

        /// <summary>
        /// Processor-defined response category code. The associated detail error code is in the &#x60;responseCode&#x60; field of the service you requested.  This field is supported only for:   - Japanese issuers  - Domestic transactions in Japan  - Comercio Latino—processor transaction ID required for troubleshooting  **Maximum length for processors**:   - Comercio Latino: 32  - All other processors: 3 
        /// </summary>
        /// <value>Processor-defined response category code. The associated detail error code is in the &#x60;responseCode&#x60; field of the service you requested.  This field is supported only for:   - Japanese issuers  - Domestic transactions in Japan  - Comercio Latino—processor transaction ID required for troubleshooting  **Maximum length for processors**:   - Comercio Latino: 32  - All other processors: 3 </value>
        [DataMember(Name="responseCategoryCode", EmitDefaultValue=false)]
        public string ResponseCategoryCode { get; set; }

        /// <summary>
        /// Name of the Japanese acquirer that processed the transaction. Returned only for JCN Gateway. Please contact the CyberSource Japan Support Group for more information. 
        /// </summary>
        /// <value>Name of the Japanese acquirer that processed the transaction. Returned only for JCN Gateway. Please contact the CyberSource Japan Support Group for more information. </value>
        [DataMember(Name="forwardedAcquirerCode", EmitDefaultValue=false)]
        public string ForwardedAcquirerCode { get; set; }

        /// <summary>
        /// Mastercard service that was used for the transaction. Mastercard provides this value to CyberSource.  Possible value:  - 53: Mastercard card-on-file token service  #### Visa Platform Connect The value for this field corresponds to the following data in the TC 33 capture file: - Record: CP01 TCR6 - Position: 133-134 - Field: Mastercard Merchant on-behalf service. **Note** This field is returned only for Visa Platform Connect. 
        /// </summary>
        /// <value>Mastercard service that was used for the transaction. Mastercard provides this value to CyberSource.  Possible value:  - 53: Mastercard card-on-file token service  #### Visa Platform Connect The value for this field corresponds to the following data in the TC 33 capture file: - Record: CP01 TCR6 - Position: 133-134 - Field: Mastercard Merchant on-behalf service. **Note** This field is returned only for Visa Platform Connect. </value>
        [DataMember(Name="masterCardServiceCode", EmitDefaultValue=false)]
        public string MasterCardServiceCode { get; set; }

        /// <summary>
        /// Result of the Mastercard card-on-file token service. Mastercard provides this value to CyberSource.  Possible values:   - &#x60;C&#x60;: Service completed successfully.  - &#x60;F&#x60;: One of the following:    - Incorrect Mastercard POS entry mode. The Mastercard POS entry mode should be 81 for an authorization or      authorization reversal.    - Incorrect Mastercard POS entry mode. The Mastercard POS entry mode should be 01 for a tokenized request.    - Token requestor ID is missing or formatted incorrectly.  - &#x60;I&#x60;: One of the following:    - Invalid token requestor ID.    - Suspended or deactivated token.    - Invalid token (not in mapping table).  - &#x60;T&#x60;: Invalid combination of token requestor ID and token.  - &#x60;U&#x60;: Expired token.  - &#x60;W&#x60;: Primary account number (PAN) listed in electronic warning bulletin.  **Note** This field is returned only for **Visa Platform Connect**. 
        /// </summary>
        /// <value>Result of the Mastercard card-on-file token service. Mastercard provides this value to CyberSource.  Possible values:   - &#x60;C&#x60;: Service completed successfully.  - &#x60;F&#x60;: One of the following:    - Incorrect Mastercard POS entry mode. The Mastercard POS entry mode should be 81 for an authorization or      authorization reversal.    - Incorrect Mastercard POS entry mode. The Mastercard POS entry mode should be 01 for a tokenized request.    - Token requestor ID is missing or formatted incorrectly.  - &#x60;I&#x60;: One of the following:    - Invalid token requestor ID.    - Suspended or deactivated token.    - Invalid token (not in mapping table).  - &#x60;T&#x60;: Invalid combination of token requestor ID and token.  - &#x60;U&#x60;: Expired token.  - &#x60;W&#x60;: Primary account number (PAN) listed in electronic warning bulletin.  **Note** This field is returned only for **Visa Platform Connect**. </value>
        [DataMember(Name="masterCardServiceReplyCode", EmitDefaultValue=false)]
        public string MasterCardServiceReplyCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsReversalsPost201ResponseProcessorInformation {\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  ResponseCode: ").Append(ResponseCode).Append("\n");
            sb.Append("  ResponseCategoryCode: ").Append(ResponseCategoryCode).Append("\n");
            sb.Append("  ForwardedAcquirerCode: ").Append(ForwardedAcquirerCode).Append("\n");
            sb.Append("  MasterCardServiceCode: ").Append(MasterCardServiceCode).Append("\n");
            sb.Append("  MasterCardServiceReplyCode: ").Append(MasterCardServiceReplyCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PtsV2PaymentsReversalsPost201ResponseProcessorInformation);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsReversalsPost201ResponseProcessorInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsReversalsPost201ResponseProcessorInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsReversalsPost201ResponseProcessorInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TransactionId == other.TransactionId ||
                    this.TransactionId != null &&
                    this.TransactionId.Equals(other.TransactionId)
                ) && 
                (
                    this.ResponseCode == other.ResponseCode ||
                    this.ResponseCode != null &&
                    this.ResponseCode.Equals(other.ResponseCode)
                ) && 
                (
                    this.ResponseCategoryCode == other.ResponseCategoryCode ||
                    this.ResponseCategoryCode != null &&
                    this.ResponseCategoryCode.Equals(other.ResponseCategoryCode)
                ) && 
                (
                    this.ForwardedAcquirerCode == other.ForwardedAcquirerCode ||
                    this.ForwardedAcquirerCode != null &&
                    this.ForwardedAcquirerCode.Equals(other.ForwardedAcquirerCode)
                ) && 
                (
                    this.MasterCardServiceCode == other.MasterCardServiceCode ||
                    this.MasterCardServiceCode != null &&
                    this.MasterCardServiceCode.Equals(other.MasterCardServiceCode)
                ) && 
                (
                    this.MasterCardServiceReplyCode == other.MasterCardServiceReplyCode ||
                    this.MasterCardServiceReplyCode != null &&
                    this.MasterCardServiceReplyCode.Equals(other.MasterCardServiceReplyCode)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.TransactionId != null)
                    hash = hash * 59 + this.TransactionId.GetHashCode();
                if (this.ResponseCode != null)
                    hash = hash * 59 + this.ResponseCode.GetHashCode();
                if (this.ResponseCategoryCode != null)
                    hash = hash * 59 + this.ResponseCategoryCode.GetHashCode();
                if (this.ForwardedAcquirerCode != null)
                    hash = hash * 59 + this.ForwardedAcquirerCode.GetHashCode();
                if (this.MasterCardServiceCode != null)
                    hash = hash * 59 + this.MasterCardServiceCode.GetHashCode();
                if (this.MasterCardServiceReplyCode != null)
                    hash = hash * 59 + this.MasterCardServiceReplyCode.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // TransactionId (string) maxLength
            if(this.TransactionId != null && this.TransactionId.Length >= 18)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionId, length must be less than or equal to 18.", new [] { "TransactionId" });
            }

            // ResponseCode (string) maxLength
            if(this.ResponseCode != null && this.ResponseCode.Length >= 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResponseCode, length must be less than or equal to 10.", new [] { "ResponseCode" });
            }

            // ResponseCategoryCode (string) maxLength
            if(this.ResponseCategoryCode != null && this.ResponseCategoryCode.Length >= 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResponseCategoryCode, length must be less than or equal to 32.", new [] { "ResponseCategoryCode" });
            }

            // ForwardedAcquirerCode (string) maxLength
            if(this.ForwardedAcquirerCode != null && this.ForwardedAcquirerCode.Length >= 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ForwardedAcquirerCode, length must be less than or equal to 32.", new [] { "ForwardedAcquirerCode" });
            }

            // MasterCardServiceCode (string) maxLength
            if(this.MasterCardServiceCode != null && this.MasterCardServiceCode.Length >= 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MasterCardServiceCode, length must be less than or equal to 2.", new [] { "MasterCardServiceCode" });
            }

            // MasterCardServiceReplyCode (string) maxLength
            if(this.MasterCardServiceReplyCode != null && this.MasterCardServiceReplyCode.Length >= 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MasterCardServiceReplyCode, length must be less than or equal to 1.", new [] { "MasterCardServiceReplyCode" });
            }

            yield break;
        }
    }

}
