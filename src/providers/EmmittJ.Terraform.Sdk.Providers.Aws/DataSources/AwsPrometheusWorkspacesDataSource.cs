using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_prometheus_workspaces.
/// </summary>
public class AwsPrometheusWorkspacesDataSource : TerraformDataSource
{
    public AwsPrometheusWorkspacesDataSource(string name) : base("aws_prometheus_workspaces", name)
    {
    }

    /// <summary>
    /// The alias_prefix attribute.
    /// </summary>
    [TerraformPropertyName("alias_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AliasPrefix { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    [TerraformPropertyName("aliases")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Aliases => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "aliases");

    /// <summary>
    /// The arns attribute.
    /// </summary>
    [TerraformPropertyName("arns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Arns => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "arns");

    /// <summary>
    /// The workspace_ids attribute.
    /// </summary>
    [TerraformPropertyName("workspace_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> WorkspaceIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "workspace_ids");

}
