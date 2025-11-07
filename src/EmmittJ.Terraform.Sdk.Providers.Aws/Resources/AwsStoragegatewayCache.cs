using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_storagegateway_cache resource.
/// </summary>
public class AwsStoragegatewayCache : TerraformResource
{
    public AwsStoragegatewayCache(string name) : base("aws_storagegateway_cache", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The disk_id attribute.
    /// </summary>
    public TerraformProperty<string>? DiskId
    {
        get => GetProperty<TerraformProperty<string>>("disk_id");
        set => this.WithProperty("disk_id", value);
    }

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    public TerraformProperty<string>? GatewayArn
    {
        get => GetProperty<TerraformProperty<string>>("gateway_arn");
        set => this.WithProperty("gateway_arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
