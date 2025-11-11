using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_virtual_mfa_device resource.
/// </summary>
public partial class AwsIamVirtualMfaDevice : TerraformResource
{
    public AwsIamVirtualMfaDevice(string name) : base("aws_iam_virtual_mfa_device", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Path { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The virtual_mfa_device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMfaDeviceName is required")]
    [TerraformProperty("virtual_mfa_device_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VirtualMfaDeviceName { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The base_32_string_seed attribute.
    /// </summary>
    [TerraformProperty("base_32_string_seed")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Base32StringSeed { get; }

    /// <summary>
    /// The enable_date attribute.
    /// </summary>
    [TerraformProperty("enable_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EnableDate { get; }

    /// <summary>
    /// The qr_code_png attribute.
    /// </summary>
    [TerraformProperty("qr_code_png")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> QrCodePng { get; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [TerraformProperty("user_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UserName { get; }

}
