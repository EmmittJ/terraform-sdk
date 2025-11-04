using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssoadmin_application_access_scope resource.
/// </summary>
public class AwsSsoadminApplicationAccessScope : TerraformResource
{
    public AwsSsoadminApplicationAccessScope(string name) : base("aws_ssoadmin_application_access_scope", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    public string? ApplicationArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_arn")?.Value;
        set => this.WithProperty("application_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The authorized_targets attribute.
    /// </summary>
    public List<string>? AuthorizedTargets
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("authorized_targets")?.Value;
        set => this.WithProperty("authorized_targets", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public string? Scope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scope")?.Value;
        set => this.WithProperty("scope", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
