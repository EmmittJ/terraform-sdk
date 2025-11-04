using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_servicecatalog_product resource.
/// </summary>
public class AwsServicecatalogProduct : TerraformResource
{
    public AwsServicecatalogProduct(string name) : base("aws_servicecatalog_product", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_time");
        this.DeclareOutput("has_default_path");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The accept_language attribute.
    /// </summary>
    public string? AcceptLanguage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("accept_language")?.Value;
        set => this.WithProperty("accept_language", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The distributor attribute.
    /// </summary>
    public string? Distributor
    {
        get => GetProperty<TerraformLiteralProperty<string>>("distributor")?.Value;
        set => this.WithProperty("distributor", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public string? Owner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("owner")?.Value;
        set => this.WithProperty("owner", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The support_description attribute.
    /// </summary>
    public string? SupportDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("support_description")?.Value;
        set => this.WithProperty("support_description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The support_email attribute.
    /// </summary>
    public string? SupportEmail
    {
        get => GetProperty<TerraformLiteralProperty<string>>("support_email")?.Value;
        set => this.WithProperty("support_email", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The support_url attribute.
    /// </summary>
    public string? SupportUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("support_url")?.Value;
        set => this.WithProperty("support_url", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformExpression CreatedTime => this["created_time"];

    /// <summary>
    /// The has_default_path attribute.
    /// </summary>
    public TerraformExpression HasDefaultPath => this["has_default_path"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
