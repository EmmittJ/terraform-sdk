using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appfabric_ingestion resource.
/// </summary>
public class AwsAppfabricIngestion : TerraformResource
{
    public AwsAppfabricIngestion(string name) : base("aws_appfabric_ingestion", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("id");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The app attribute.
    /// </summary>
    public string? App
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app")?.Value;
        set => this.WithProperty("app", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The app_bundle_arn attribute.
    /// </summary>
    public string? AppBundleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_bundle_arn")?.Value;
        set => this.WithProperty("app_bundle_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ingestion_type attribute.
    /// </summary>
    public string? IngestionType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ingestion_type")?.Value;
        set => this.WithProperty("ingestion_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public string? TenantId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenant_id")?.Value;
        set => this.WithProperty("tenant_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
