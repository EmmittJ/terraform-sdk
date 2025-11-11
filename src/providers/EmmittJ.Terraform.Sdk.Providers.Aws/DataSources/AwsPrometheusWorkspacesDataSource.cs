using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_prometheus_workspaces.
/// </summary>
public partial class AwsPrometheusWorkspacesDataSource : TerraformDataSource
{
    public AwsPrometheusWorkspacesDataSource(string name) : base("aws_prometheus_workspaces", name)
    {
    }

    /// <summary>
    /// The alias_prefix attribute.
    /// </summary>
    [TerraformProperty("alias_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AliasPrefix { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    [TerraformProperty("aliases")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Aliases { get; }

    /// <summary>
    /// The arns attribute.
    /// </summary>
    [TerraformProperty("arns")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Arns { get; }

    /// <summary>
    /// The workspace_ids attribute.
    /// </summary>
    [TerraformProperty("workspace_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> WorkspaceIds { get; }

}
