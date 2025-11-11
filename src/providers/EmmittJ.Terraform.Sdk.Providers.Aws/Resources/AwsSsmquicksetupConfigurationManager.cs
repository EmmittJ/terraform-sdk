using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration_definition in .
/// Nesting mode: list
/// </summary>
public partial class AwsSsmquicksetupConfigurationManagerConfigurationDefinitionBlock : TerraformBlockBase
{

    /// <summary>
    /// The local_deployment_administration_role_arn attribute.
    /// </summary>
    [TerraformProperty("local_deployment_administration_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LocalDeploymentAdministrationRoleArn { get; set; }

    /// <summary>
    /// The local_deployment_execution_role_name attribute.
    /// </summary>
    [TerraformProperty("local_deployment_execution_role_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LocalDeploymentExecutionRoleName { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameters is required")]
    [TerraformProperty("parameters")]
    // Required argument - source generator will implement get/set
    public required partial TerraformMap<string> Parameters { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The type_version attribute.
    /// </summary>
    [TerraformProperty("type_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TypeVersion { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsSsmquicksetupConfigurationManagerTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_ssmquicksetup_configuration_manager resource.
/// </summary>
public partial class AwsSsmquicksetupConfigurationManager : TerraformResource
{
    public AwsSsmquicksetupConfigurationManager(string name) : base("aws_ssmquicksetup_configuration_manager", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for configuration_definition.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("configuration_definition")]
    public partial TerraformList<TerraformBlock<AwsSsmquicksetupConfigurationManagerConfigurationDefinitionBlock>>? ConfigurationDefinition { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsSsmquicksetupConfigurationManagerTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The manager_arn attribute.
    /// </summary>
    [TerraformProperty("manager_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ManagerArn { get; }

    /// <summary>
    /// The status_summaries attribute.
    /// </summary>
    [TerraformProperty("status_summaries")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> StatusSummaries { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
