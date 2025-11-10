using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_virtual_mfa_device resource.
/// </summary>
public class AwsIamVirtualMfaDevice : TerraformResource
{
    public AwsIamVirtualMfaDevice(string name) : base("aws_iam_virtual_mfa_device", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Path { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The virtual_mfa_device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMfaDeviceName is required")]
    [TerraformPropertyName("virtual_mfa_device_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VirtualMfaDeviceName { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The base_32_string_seed attribute.
    /// </summary>
    [TerraformPropertyName("base_32_string_seed")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Base32StringSeed => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "base_32_string_seed");

    /// <summary>
    /// The enable_date attribute.
    /// </summary>
    [TerraformPropertyName("enable_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EnableDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "enable_date");

    /// <summary>
    /// The qr_code_png attribute.
    /// </summary>
    [TerraformPropertyName("qr_code_png")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> QrCodePng => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "qr_code_png");

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [TerraformPropertyName("user_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_name");

}
