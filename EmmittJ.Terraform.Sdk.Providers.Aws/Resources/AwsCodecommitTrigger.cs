using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codecommit_trigger resource.
/// </summary>
public class AwsCodecommitTrigger : TerraformResource
{
    public AwsCodecommitTrigger(string name) : base("aws_codecommit_trigger", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("configuration_id");
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
    /// The repository_name attribute.
    /// </summary>
    public string? RepositoryName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_name")?.Value;
        set => this.WithProperty("repository_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The configuration_id attribute.
    /// </summary>
    public TerraformExpression ConfigurationId => this["configuration_id"];

}
