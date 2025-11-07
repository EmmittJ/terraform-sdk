using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudtrail_event_data_store resource.
/// </summary>
public class AwsCloudtrailEventDataStore : TerraformResource
{
    public AwsCloudtrailEventDataStore(string name) : base("aws_cloudtrail_event_data_store", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The billing_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BillingMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("billing_mode");
        set => this.WithProperty("billing_mode", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The multi_region_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? MultiRegionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("multi_region_enabled");
        set => this.WithProperty("multi_region_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The organization_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? OrganizationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("organization_enabled");
        set => this.WithProperty("organization_enabled", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The retention_period attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? RetentionPeriod
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention_period");
        set => this.WithProperty("retention_period", value);
    }

    /// <summary>
    /// The suspend attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Suspend
    {
        get => GetProperty<TerraformLiteralProperty<string>>("suspend");
        set => this.WithProperty("suspend", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The termination_protection_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? TerminationProtectionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("termination_protection_enabled");
        set => this.WithProperty("termination_protection_enabled", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
