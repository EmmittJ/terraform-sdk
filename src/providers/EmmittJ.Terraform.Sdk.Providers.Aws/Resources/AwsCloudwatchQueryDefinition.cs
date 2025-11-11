using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_query_definition resource.
/// </summary>
public partial class AwsCloudwatchQueryDefinition : TerraformResource
{
    public AwsCloudwatchQueryDefinition(string name) : base("aws_cloudwatch_query_definition", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The log_group_names attribute.
    /// </summary>
    [TerraformProperty("log_group_names")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? LogGroupNames { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The query_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryString is required")]
    [TerraformProperty("query_string")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> QueryString { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The query_definition_id attribute.
    /// </summary>
    [TerraformProperty("query_definition_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> QueryDefinitionId { get; }

}
