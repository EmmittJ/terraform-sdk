using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_sesv2_dedicated_ip_pool.
/// </summary>
public class AwsSesv2DedicatedIpPoolDataSource : TerraformDataSource
{
    public AwsSesv2DedicatedIpPoolDataSource(string name) : base("aws_sesv2_dedicated_ip_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("dedicated_ips");
        this.WithOutput("scaling_mode");
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
    /// The pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolName is required")]
    public required TerraformProperty<string> PoolName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("pool_name");
        set => this.WithProperty("pool_name", value);
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The dedicated_ips attribute.
    /// </summary>
    public TerraformExpression DedicatedIps => this["dedicated_ips"];

    /// <summary>
    /// The scaling_mode attribute.
    /// </summary>
    public TerraformExpression ScalingMode => this["scaling_mode"];

}
