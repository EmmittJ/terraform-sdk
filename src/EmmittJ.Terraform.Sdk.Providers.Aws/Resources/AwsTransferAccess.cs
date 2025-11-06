using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_transfer_access resource.
/// </summary>
public class AwsTransferAccess : TerraformResource
{
    public AwsTransferAccess(string name) : base("aws_transfer_access", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    public string? ExternalId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("external_id")?.Value;
        set => this.WithProperty("external_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The home_directory attribute.
    /// </summary>
    public string? HomeDirectory
    {
        get => GetProperty<TerraformLiteralProperty<string>>("home_directory")?.Value;
        set => this.WithProperty("home_directory", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The home_directory_type attribute.
    /// </summary>
    public string? HomeDirectoryType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("home_directory_type")?.Value;
        set => this.WithProperty("home_directory_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The policy attribute.
    /// </summary>
    public string? Policy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy")?.Value;
        set => this.WithProperty("policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    public string? Role
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role")?.Value;
        set => this.WithProperty("role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    public string? ServerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_id")?.Value;
        set => this.WithProperty("server_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
