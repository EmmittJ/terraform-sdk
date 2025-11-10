using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_vpclattice_service_network.
/// </summary>
public class AwsVpclatticeServiceNetworkDataSource : TerraformDataSource
{
    public AwsVpclatticeServiceNetworkDataSource(string name) : base("aws_vpclattice_service_network", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("auth_type");
        SetOutput("created_at");
        SetOutput("last_updated_at");
        SetOutput("name");
        SetOutput("number_of_associated_services");
        SetOutput("number_of_associated_vpcs");
        SetOutput("id");
        SetOutput("region");
        SetOutput("service_network_identifier");
        SetOutput("tags");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// The service_network_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNetworkIdentifier is required")]
    public required TerraformProperty<string> ServiceNetworkIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_network_identifier");
        set => SetProperty("service_network_identifier", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    public TerraformExpression AuthType => this["auth_type"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The last_updated_at attribute.
    /// </summary>
    public TerraformExpression LastUpdatedAt => this["last_updated_at"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The number_of_associated_services attribute.
    /// </summary>
    public TerraformExpression NumberOfAssociatedServices => this["number_of_associated_services"];

    /// <summary>
    /// The number_of_associated_vpcs attribute.
    /// </summary>
    public TerraformExpression NumberOfAssociatedVpcs => this["number_of_associated_vpcs"];

}
