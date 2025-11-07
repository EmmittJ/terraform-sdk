using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_licensemanager_received_license.
/// </summary>
public class AwsLicensemanagerReceivedLicenseDataSource : TerraformDataSource
{
    public AwsLicensemanagerReceivedLicenseDataSource(string name) : base("aws_licensemanager_received_license", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("beneficiary");
        this.DeclareOutput("consumption_configuration");
        this.DeclareOutput("create_time");
        this.DeclareOutput("entitlements");
        this.DeclareOutput("home_region");
        this.DeclareOutput("issuer");
        this.DeclareOutput("license_metadata");
        this.DeclareOutput("license_name");
        this.DeclareOutput("product_name");
        this.DeclareOutput("product_sku");
        this.DeclareOutput("received_metadata");
        this.DeclareOutput("status");
        this.DeclareOutput("validity");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The license_arn attribute.
    /// </summary>
    public TerraformProperty<string>? LicenseArn
    {
        get => GetProperty<TerraformProperty<string>>("license_arn");
        set => this.WithProperty("license_arn", value);
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
    /// The beneficiary attribute.
    /// </summary>
    public TerraformExpression Beneficiary => this["beneficiary"];

    /// <summary>
    /// The consumption_configuration attribute.
    /// </summary>
    public TerraformExpression ConsumptionConfiguration => this["consumption_configuration"];

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The entitlements attribute.
    /// </summary>
    public TerraformExpression Entitlements => this["entitlements"];

    /// <summary>
    /// The home_region attribute.
    /// </summary>
    public TerraformExpression HomeRegion => this["home_region"];

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformExpression Issuer => this["issuer"];

    /// <summary>
    /// The license_metadata attribute.
    /// </summary>
    public TerraformExpression LicenseMetadata => this["license_metadata"];

    /// <summary>
    /// The license_name attribute.
    /// </summary>
    public TerraformExpression LicenseName => this["license_name"];

    /// <summary>
    /// The product_name attribute.
    /// </summary>
    public TerraformExpression ProductName => this["product_name"];

    /// <summary>
    /// The product_sku attribute.
    /// </summary>
    public TerraformExpression ProductSku => this["product_sku"];

    /// <summary>
    /// The received_metadata attribute.
    /// </summary>
    public TerraformExpression ReceivedMetadata => this["received_metadata"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The validity attribute.
    /// </summary>
    public TerraformExpression Validity => this["validity"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
