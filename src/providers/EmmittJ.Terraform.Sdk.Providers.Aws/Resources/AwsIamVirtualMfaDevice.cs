using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_virtual_mfa_device Terraform resource.
/// Manages a aws_iam_virtual_mfa_device resource.
/// </summary>
public partial class AwsIamVirtualMfaDevice(string name) : TerraformResource("aws_iam_virtual_mfa_device", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The virtual_mfa_device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMfaDeviceName is required")]
    public required TerraformValue<string> VirtualMfaDeviceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_mfa_device_name");
        set => SetArgument("virtual_mfa_device_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The base_32_string_seed attribute.
    /// </summary>
    public TerraformValue<string> Base32StringSeed
        => AsReference("base_32_string_seed");

    /// <summary>
    /// The enable_date attribute.
    /// </summary>
    public TerraformValue<string> EnableDate
        => AsReference("enable_date");

    /// <summary>
    /// The qr_code_png attribute.
    /// </summary>
    public TerraformValue<string> QrCodePng
        => AsReference("qr_code_png");

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformValue<string> UserName
        => AsReference("user_name");

}
