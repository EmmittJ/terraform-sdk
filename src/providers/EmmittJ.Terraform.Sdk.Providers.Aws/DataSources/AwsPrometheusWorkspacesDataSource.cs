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
        SetOutput("aliases");
        SetOutput("arns");
        SetOutput("workspace_ids");
        SetOutput("alias_prefix");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The alias_prefix attribute.
    /// </summary>
    public TerraformProperty<string> AliasPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("alias_prefix");
        set => SetProperty("alias_prefix", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
