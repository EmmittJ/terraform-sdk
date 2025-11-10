using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ec2_public_ipv4_pool.
/// </summary>
public class AwsEc2PublicIpv4PoolDataSource : TerraformDataSource
{
    public AwsEc2PublicIpv4PoolDataSource(string name) : base("aws_ec2_public_ipv4_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("description");
        SetOutput("network_border_group");
        SetOutput("pool_address_ranges");
        SetOutput("total_address_count");
        SetOutput("total_available_address_count");
        SetOutput("id");
        SetOutput("pool_id");
        SetOutput("region");
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
    /// The pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolId is required")]
    public required TerraformProperty<string> PoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pool_id");
        set => SetProperty("pool_id", value);
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
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The network_border_group attribute.
    /// </summary>
    public TerraformExpression NetworkBorderGroup => this["network_border_group"];

    /// <summary>
    /// The pool_address_ranges attribute.
    /// </summary>
    public TerraformExpression PoolAddressRanges => this["pool_address_ranges"];

    /// <summary>
    /// The total_address_count attribute.
    /// </summary>
    public TerraformExpression TotalAddressCount => this["total_address_count"];

    /// <summary>
    /// The total_available_address_count attribute.
    /// </summary>
    public TerraformExpression TotalAvailableAddressCount => this["total_available_address_count"];

}
