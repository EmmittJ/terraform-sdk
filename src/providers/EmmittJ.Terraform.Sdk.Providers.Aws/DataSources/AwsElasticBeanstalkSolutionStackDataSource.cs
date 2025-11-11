using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_elastic_beanstalk_solution_stack.
/// </summary>
public partial class AwsElasticBeanstalkSolutionStackDataSource : TerraformDataSource
{
    public AwsElasticBeanstalkSolutionStackDataSource(string name) : base("aws_elastic_beanstalk_solution_stack", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformProperty("most_recent")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? MostRecent { get; set; }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NameRegex is required")]
    [TerraformProperty("name_regex")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NameRegex { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

}
