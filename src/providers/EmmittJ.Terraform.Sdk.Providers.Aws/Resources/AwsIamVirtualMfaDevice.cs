using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_virtual_mfa_device resource.
/// </summary>
public class AwsIamVirtualMfaDevice : TerraformResource
{
    public AwsIamVirtualMfaDevice(string name) : base("aws_iam_virtual_mfa_device", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("base_32_string_seed");
        SetOutput("enable_date");
        SetOutput("qr_code_png");
        SetOutput("user_name");
        SetOutput("id");
        SetOutput("path");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("virtual_mfa_device_name");
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
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string> Path
    {
        get => GetRequiredOutput<TerraformProperty<string>>("path");
        set => SetProperty("path", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The virtual_mfa_device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMfaDeviceName is required")]
    public required TerraformProperty<string> VirtualMfaDeviceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_mfa_device_name");
        set => SetProperty("virtual_mfa_device_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The base_32_string_seed attribute.
    /// </summary>
    public TerraformExpression Base32StringSeed => this["base_32_string_seed"];

    /// <summary>
    /// The enable_date attribute.
    /// </summary>
    public TerraformExpression EnableDate => this["enable_date"];

    /// <summary>
    /// The qr_code_png attribute.
    /// </summary>
    public TerraformExpression QrCodePng => this["qr_code_png"];

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformExpression UserName => this["user_name"];

}
