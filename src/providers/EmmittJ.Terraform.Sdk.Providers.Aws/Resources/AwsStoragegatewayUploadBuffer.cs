using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_storagegateway_upload_buffer resource.
/// </summary>
public class AwsStoragegatewayUploadBuffer : TerraformResource
{
    public AwsStoragegatewayUploadBuffer(string name) : base("aws_storagegateway_upload_buffer", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("disk_id");
        SetOutput("disk_path");
        SetOutput("gateway_arn");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The disk_id attribute.
    /// </summary>
    public TerraformProperty<string> DiskId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("disk_id");
        set => SetProperty("disk_id", value);
    }

    /// <summary>
    /// The disk_path attribute.
    /// </summary>
    public TerraformProperty<string> DiskPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("disk_path");
        set => SetProperty("disk_path", value);
    }

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayArn is required")]
    public required TerraformProperty<string> GatewayArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gateway_arn");
        set => SetProperty("gateway_arn", value);
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

}
