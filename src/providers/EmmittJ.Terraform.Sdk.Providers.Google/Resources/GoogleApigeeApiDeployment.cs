using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleApigeeApiDeploymentTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a google_apigee_api_deployment resource.
/// </summary>
public partial class GoogleApigeeApiDeployment : TerraformResource
{
    public GoogleApigeeApiDeployment(string name) : base("google_apigee_api_deployment", name)
    {
    }

    /// <summary>
    /// The Apigee Environment associated with the Apigee API deployment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    [TerraformProperty("environment")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Environment { get; set; }

    /// <summary>
    /// The Apigee Organization associated with the Apigee API deployment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformProperty("org_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OrgId { get; set; }

    /// <summary>
    /// The Apigee API associated with the Apigee API deployment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProxyId is required")]
    [TerraformProperty("proxy_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProxyId { get; set; }

    /// <summary>
    /// The revision of the API proxy to be deployed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    [TerraformProperty("revision")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Revision { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleApigeeApiDeploymentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The ID of the API deployment in the format &#39;organizations/{{org_id}}/environments/{{environment}}/apis/{{proxy_id}}/revisions/{{revision}}/deployments&#39;.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

}
