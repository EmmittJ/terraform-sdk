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
    public TerraformProperty<string>? App
    {
        get => GetProperty<TerraformProperty<string>>("app");
        set => this.WithProperty("app", value);
    }

    /// <summary>
    /// The app_bundle_arn attribute.
    /// </summary>
    public TerraformProperty<string>? AppBundleArn
    {
        get => GetProperty<TerraformProperty<string>>("app_bundle_arn");
        set => this.WithProperty("app_bundle_arn", value);
    }

    /// <summary>
    /// The ingestion_type attribute.
    /// </summary>
    public TerraformProperty<string>? IngestionType
    {
        get => GetProperty<TerraformProperty<string>>("ingestion_type");
        set => this.WithProperty("ingestion_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => this.WithProperty("tenant_id", value);
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
