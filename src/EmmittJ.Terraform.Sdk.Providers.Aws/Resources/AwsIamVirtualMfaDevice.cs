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
        this.DeclareOutput("arn");
        this.DeclareOutput("base_32_string_seed");
        this.DeclareOutput("enable_date");
        this.DeclareOutput("qr_code_png");
        this.DeclareOutput("user_name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public string? Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("path")?.Value;
        set => this.WithProperty("path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The virtual_mfa_device_name attribute.
    /// </summary>
    public string? VirtualMfaDeviceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_mfa_device_name")?.Value;
        set => this.WithProperty("virtual_mfa_device_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
