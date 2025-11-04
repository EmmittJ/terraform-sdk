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
    public string? DiskId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("disk_id")?.Value;
        set => this.WithProperty("disk_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    public string? GatewayArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gateway_arn")?.Value;
        set => this.WithProperty("gateway_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
