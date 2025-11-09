using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dx_connection.
/// </summary>
public class AwsDxConnectionDataSource : TerraformDataSource
{
    public AwsDxConnectionDataSource(string name) : base("aws_dx_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("aws_device");
        this.DeclareOutput("bandwidth");
        this.DeclareOutput("location");
        this.DeclareOutput("owner_account_id");
        this.DeclareOutput("partner_name");
        this.DeclareOutput("provider_name");
        this.DeclareOutput("state");
        this.DeclareOutput("vlan_id");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    public TerraformExpression AwsDevice => this["aws_device"];

    /// <summary>
    /// The bandwidth attribute.
    /// </summary>
    public TerraformExpression Bandwidth => this["bandwidth"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformExpression OwnerAccountId => this["owner_account_id"];

    /// <summary>
    /// The partner_name attribute.
    /// </summary>
    public TerraformExpression PartnerName => this["partner_name"];

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    public TerraformExpression ProviderName => this["provider_name"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    public TerraformExpression VlanId => this["vlan_id"];

}
