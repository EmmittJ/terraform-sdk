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
        this.DeclareOutput("arn");
        this.DeclareOutput("auth_type");
        this.DeclareOutput("created_at");
        this.DeclareOutput("last_updated_at");
        this.DeclareOutput("name");
        this.DeclareOutput("number_of_associated_services");
        this.DeclareOutput("number_of_associated_vpcs");
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
    /// The service_network_identifier attribute.
    /// </summary>
    public string? ServiceNetworkIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_network_identifier")?.Value;
        set => this.WithProperty("service_network_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
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
