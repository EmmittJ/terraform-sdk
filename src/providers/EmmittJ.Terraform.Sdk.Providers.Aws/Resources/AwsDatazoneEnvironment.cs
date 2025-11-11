using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDatazoneEnvironmentTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for user_parameters in .
/// Nesting mode: list
/// </summary>
public partial class AwsDatazoneEnvironmentUserParametersBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Manages a aws_datazone_environment resource.
/// </summary>
public partial class AwsDatazoneEnvironment : TerraformResource
{
    public AwsDatazoneEnvironment(string name) : base("aws_datazone_environment", name)
    {
    }

    /// <summary>
    /// The account_identifier attribute.
    /// </summary>
    [TerraformProperty("account_identifier")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AccountIdentifier { get; set; }

    /// <summary>
    /// The account_region attribute.
    /// </summary>
    [TerraformProperty("account_region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AccountRegion { get; set; }

    /// <summary>
    /// The blueprint_identifier attribute.
    /// </summary>
    [TerraformProperty("blueprint_identifier")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> BlueprintIdentifier { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The domain_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainIdentifier is required")]
    [TerraformProperty("domain_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainIdentifier { get; set; }

    /// <summary>
    /// The glossary_terms attribute.
    /// </summary>
    [TerraformProperty("glossary_terms")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? GlossaryTerms { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The profile_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileIdentifier is required")]
    [TerraformProperty("profile_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProfileIdentifier { get; set; }

    /// <summary>
    /// The project_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectIdentifier is required")]
    [TerraformProperty("project_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProjectIdentifier { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsDatazoneEnvironmentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for user_parameters.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("user_parameters")]
    public partial TerraformList<TerraformBlock<AwsDatazoneEnvironmentUserParametersBlock>>? UserParameters { get; set; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    [TerraformProperty("created_by")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedBy { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The last_deployment attribute.
    /// </summary>
    [TerraformProperty("last_deployment")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> LastDeployment { get; }

    /// <summary>
    /// The provider_environment attribute.
    /// </summary>
    [TerraformProperty("provider_environment")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ProviderEnvironment { get; }

    /// <summary>
    /// The provisioned_resources attribute.
    /// </summary>
    [TerraformProperty("provisioned_resources")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ProvisionedResources { get; }

}
