using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_db_subnet_group.
/// </summary>
public class AwsDbSubnetGroupDataSource : TerraformDataSource
{
    public AwsDbSubnetGroupDataSource(string name) : base("aws_db_subnet_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("description");
        this.DeclareOutput("status");
        this.DeclareOutput("subnet_ids");
        this.DeclareOutput("supported_network_types");
        this.DeclareOutput("vpc_id");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformExpression SubnetIds => this["subnet_ids"];

    /// <summary>
    /// The supported_network_types attribute.
    /// </summary>
    public TerraformExpression SupportedNetworkTypes => this["supported_network_types"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
