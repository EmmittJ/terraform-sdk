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
        this.DeclareOutput("arn");
        this.DeclareOutput("dedicated_ips");
        this.DeclareOutput("scaling_mode");
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
    /// The pool_name attribute.
    /// </summary>
    public string? PoolName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pool_name")?.Value;
        set => this.WithProperty("pool_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The dedicated_ips attribute.
    /// </summary>
    public TerraformExpression DedicatedIps => this["dedicated_ips"];

    /// <summary>
    /// The scaling_mode attribute.
    /// </summary>
    public TerraformExpression ScalingMode => this["scaling_mode"];

}
