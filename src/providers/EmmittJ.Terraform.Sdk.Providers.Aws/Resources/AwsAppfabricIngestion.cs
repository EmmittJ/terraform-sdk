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
        SetOutput("arn");
        SetOutput("id");
        SetOutput("tags_all");
        SetOutput("app");
        SetOutput("app_bundle_arn");
        SetOutput("ingestion_type");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tenant_id");
    }

    /// <summary>
    /// The app attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "App is required")]
    public required TerraformProperty<string> App
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app");
        set => SetProperty("app", value);
    }

    /// <summary>
    /// The app_bundle_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppBundleArn is required")]
    public required TerraformProperty<string> AppBundleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app_bundle_arn");
        set => SetProperty("app_bundle_arn", value);
    }

    /// <summary>
    /// The ingestion_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngestionType is required")]
    public required TerraformProperty<string> IngestionType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ingestion_type");
        set => SetProperty("ingestion_type", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformProperty<string> TenantId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tenant_id");
        set => SetProperty("tenant_id", value);
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
