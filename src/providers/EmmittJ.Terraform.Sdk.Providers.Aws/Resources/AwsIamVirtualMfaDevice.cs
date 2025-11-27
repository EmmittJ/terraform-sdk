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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The virtual_mfa_device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMfaDeviceName is required")]
    public required TerraformValue<string> VirtualMfaDeviceName
    {
        get => new TerraformReference<string>(this, "virtual_mfa_device_name");
        set => SetArgument("virtual_mfa_device_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The base_32_string_seed attribute.
    /// </summary>
    public TerraformValue<string> Base32StringSeed
    {
        get => new TerraformReference<string>(this, "base_32_string_seed");
    }

    /// <summary>
    /// The enable_date attribute.
    /// </summary>
    public TerraformValue<string> EnableDate
    {
        get => new TerraformReference<string>(this, "enable_date");
    }

    /// <summary>
    /// The qr_code_png attribute.
    /// </summary>
    public TerraformValue<string> QrCodePng
    {
        get => new TerraformReference<string>(this, "qr_code_png");
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformValue<string> UserName
    {
        get => new TerraformReference<string>(this, "user_name");
    }

}
