using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sagemaker_app resource.
/// </summary>
public class AwsSagemakerApp : TerraformResource
{
    public AwsSagemakerApp(string name) : base("aws_sagemaker_app", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The app_name attribute.
    /// </summary>
    public string? AppName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_name")?.Value;
        set => this.WithProperty("app_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The app_type attribute.
    /// </summary>
    public string? AppType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_type")?.Value;
        set => this.WithProperty("app_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    public string? DomainId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_id")?.Value;
        set => this.WithProperty("domain_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The space_name attribute.
    /// </summary>
    public string? SpaceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("space_name")?.Value;
        set => this.WithProperty("space_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The user_profile_name attribute.
    /// </summary>
    public string? UserProfileName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_profile_name")?.Value;
        set => this.WithProperty("user_profile_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
