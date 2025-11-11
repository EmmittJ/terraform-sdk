using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_query_definition resource.
/// </summary>
public class AwsCloudwatchQueryDefinition : TerraformResource
{
    public AwsCloudwatchQueryDefinition(string name) : base("aws_cloudwatch_query_definition", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The log_group_names attribute.
    /// </summary>
    [TerraformPropertyName("log_group_names")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? LogGroupNames { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The query_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryString is required")]
    [TerraformPropertyName("query_string")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> QueryString { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The query_definition_id attribute.
    /// </summary>
    [TerraformPropertyName("query_definition_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> QueryDefinitionId => new TerraformReference(this, "query_definition_id");

}
