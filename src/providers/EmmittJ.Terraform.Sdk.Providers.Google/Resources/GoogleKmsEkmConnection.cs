using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for service_resolvers in .
/// Nesting mode: list
/// </summary>
public partial class GoogleKmsEkmConnectionServiceResolversBlock() : TerraformBlock("service_resolvers")
{
    /// <summary>
    /// Optional. The filter applied to the endpoints of the resolved service. If no filter is specified, all endpoints will be considered. An endpoint will be chosen arbitrarily from the filtered list for each request. For endpoint filter syntax and examples, see https://cloud.google.com/service-directory/docs/reference/rpc/google.cloud.servicedirectory.v1#resolveservicerequest.
    /// </summary>
    [TerraformProperty("endpoint_filter")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EndpointFilter { get; set; }

    /// <summary>
    /// Required. The hostname of the EKM replica used at TLS and HTTP layers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformProperty("hostname")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Hostname { get; set; }

    /// <summary>
    /// Required. The resource name of the Service Directory service pointing to an EKM replica, in the format projects/*/locations/*/namespaces/*/services/*
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceDirectoryService is required")]
    [TerraformProperty("service_directory_service")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceDirectoryService { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleKmsEkmConnectionTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_kms_ekm_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleKmsEkmConnection : TerraformResource
{
    public GoogleKmsEkmConnection(string name) : base("google_kms_ekm_connection", name)
    {
    }

    /// <summary>
    /// Optional. Identifies the EKM Crypto Space that this EkmConnection maps to. Note: This field is required if KeyManagementMode is CLOUD_KMS.
    /// </summary>
    [TerraformProperty("crypto_space_path")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CryptoSpacePath { get; set; }

    /// <summary>
    /// Optional. Etag of the currently stored EkmConnection.
    /// </summary>
    [TerraformProperty("etag")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Etag { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Optional. Describes who can perform control plane operations on the EKM. If unset, this defaults to MANUAL Default value: &amp;quot;MANUAL&amp;quot; Possible values: [&amp;quot;MANUAL&amp;quot;, &amp;quot;CLOUD_KMS&amp;quot;]
    /// </summary>
    [TerraformProperty("key_management_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyManagementMode { get; set; }

    /// <summary>
    /// The location for the EkmConnection.
    /// A full list of valid locations can be found by running &#39;gcloud kms locations list&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The resource name for the EkmConnection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for service_resolvers.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceResolvers is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ServiceResolvers block(s) required")]
    [TerraformProperty("service_resolvers")]
    public required TerraformList<GoogleKmsEkmConnectionServiceResolversBlock> ServiceResolvers { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleKmsEkmConnectionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. The time at which the EkmConnection was created.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

}
