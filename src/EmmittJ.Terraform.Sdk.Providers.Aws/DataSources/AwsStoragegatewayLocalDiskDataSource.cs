using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_storagegateway_local_disk.
/// </summary>
public class AwsStoragegatewayLocalDiskDataSource : TerraformDataSource
{
    public AwsStoragegatewayLocalDiskDataSource(string name) : base("aws_storagegateway_local_disk", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("disk_id");
    }

    /// <summary>
    /// The disk_node attribute.
    /// </summary>
    public TerraformProperty<string>? DiskNode
    {
        get => GetProperty<TerraformProperty<string>>("disk_node");
        set => this.WithProperty("disk_node", value);
    }

    /// <summary>
    /// The disk_path attribute.
    /// </summary>
    public TerraformProperty<string>? DiskPath
    {
        get => GetProperty<TerraformProperty<string>>("disk_path");
        set => this.WithProperty("disk_path", value);
    }

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayArn is required")]
    public required TerraformProperty<string> GatewayArn
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

    /// <summary>
    /// The disk_id attribute.
    /// </summary>
    public TerraformExpression DiskId => this["disk_id"];

}
