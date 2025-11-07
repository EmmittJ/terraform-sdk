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
    public TerraformProperty<string>? ExternalId
    {
        get => GetProperty<TerraformProperty<string>>("external_id");
        set => this.WithProperty("external_id", value);
    }

    /// <summary>
    /// The home_directory attribute.
    /// </summary>
    public TerraformProperty<string>? HomeDirectory
    {
        get => GetProperty<TerraformProperty<string>>("home_directory");
        set => this.WithProperty("home_directory", value);
    }

    /// <summary>
    /// The home_directory_type attribute.
    /// </summary>
    public TerraformProperty<string>? HomeDirectoryType
    {
        get => GetProperty<TerraformProperty<string>>("home_directory_type");
        set => this.WithProperty("home_directory_type", value);
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
    /// The policy attribute.
    /// </summary>
    public TerraformProperty<string>? Policy
    {
        get => GetProperty<TerraformProperty<string>>("policy");
        set => this.WithProperty("policy", value);
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
    /// The role attribute.
    /// </summary>
    public TerraformProperty<string>? Role
    {
        get => GetProperty<TerraformProperty<string>>("role");
        set => this.WithProperty("role", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    public TerraformProperty<string>? ServerId
    {
        get => GetProperty<TerraformProperty<string>>("server_id");
        set => this.WithProperty("server_id", value);
    }

}
