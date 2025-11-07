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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("path");
        set => this.WithProperty("path", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The virtual_mfa_device_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VirtualMfaDeviceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_mfa_device_name");
        set => this.WithProperty("virtual_mfa_device_name", value);
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
