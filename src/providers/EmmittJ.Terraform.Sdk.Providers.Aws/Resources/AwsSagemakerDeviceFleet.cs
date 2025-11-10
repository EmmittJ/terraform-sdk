using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for output_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDeviceFleetOutputConfigBlock : TerraformBlock
{
    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The s3_output_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3OutputLocation is required")]
    public required TerraformProperty<string> S3OutputLocation
    {
        get => GetRequiredProperty<TerraformProperty<string>>("s3_output_location");
        set => WithProperty("s3_output_location", value);
    }

}

/// <summary>
/// Manages a aws_sagemaker_device_fleet resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerDeviceFleet : TerraformResource
{
    public AwsSagemakerDeviceFleet(string name) : base("aws_sagemaker_device_fleet", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("iot_role_alias");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The device_fleet_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceFleetName is required")]
    public required TerraformProperty<string> DeviceFleetName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("device_fleet_name");
        set => this.WithProperty("device_fleet_name", value);
    }

    /// <summary>
    /// The enable_iot_role_alias attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableIotRoleAlias
    {
        get => GetProperty<TerraformProperty<bool>>("enable_iot_role_alias");
        set => this.WithProperty("enable_iot_role_alias", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for output_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OutputConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputConfig block(s) allowed")]
    public List<AwsSagemakerDeviceFleetOutputConfigBlock>? OutputConfig
    {
        get => GetProperty<List<AwsSagemakerDeviceFleetOutputConfigBlock>>("output_config");
        set => this.WithProperty("output_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The iot_role_alias attribute.
    /// </summary>
    public TerraformExpression IotRoleAlias => this["iot_role_alias"];

}
