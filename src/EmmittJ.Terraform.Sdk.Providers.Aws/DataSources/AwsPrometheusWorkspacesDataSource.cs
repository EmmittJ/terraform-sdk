using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_prometheus_workspaces.
/// </summary>
public class AwsPrometheusWorkspacesDataSource : TerraformDataSource
{
    public AwsPrometheusWorkspacesDataSource(string name) : base("aws_prometheus_workspaces", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("aliases");
        this.DeclareOutput("arns");
        this.DeclareOutput("workspace_ids");
    }

    /// <summary>
    /// The alias_prefix attribute.
    /// </summary>
    public string? AliasPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alias_prefix")?.Value;
        set => this.WithProperty("alias_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    public TerraformExpression Aliases => this["aliases"];

    /// <summary>
    /// The arns attribute.
    /// </summary>
    public TerraformExpression Arns => this["arns"];

    /// <summary>
    /// The workspace_ids attribute.
    /// </summary>
    public TerraformExpression WorkspaceIds => this["workspace_ids"];

}
