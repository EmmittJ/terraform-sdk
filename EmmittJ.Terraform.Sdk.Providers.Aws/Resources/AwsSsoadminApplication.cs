using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssoadmin_application resource.
/// </summary>
public class AwsSsoadminApplication : TerraformResource
{
    public AwsSsoadminApplication(string name) : base("aws_ssoadmin_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("application_account");
        this.DeclareOutput("application_arn");
        this.DeclareOutput("id");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The application_provider_arn attribute.
    /// </summary>
    public string? ApplicationProviderArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_provider_arn")?.Value;
        set => this.WithProperty("application_provider_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The client_token attribute.
    /// </summary>
    public string? ClientToken
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_token")?.Value;
        set => this.WithProperty("client_token", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_arn attribute.
    /// </summary>
    public string? InstanceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_arn")?.Value;
        set => this.WithProperty("instance_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public string? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status")?.Value;
        set => this.WithProperty("status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The application_account attribute.
    /// </summary>
    public TerraformExpression ApplicationAccount => this["application_account"];

    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    public TerraformExpression ApplicationArn => this["application_arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
