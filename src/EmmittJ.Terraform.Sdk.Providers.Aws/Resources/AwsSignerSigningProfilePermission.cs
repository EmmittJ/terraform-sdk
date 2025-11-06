using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_signer_signing_profile_permission resource.
/// </summary>
public class AwsSignerSigningProfilePermission : TerraformResource
{
    public AwsSignerSigningProfilePermission(string name) : base("aws_signer_signing_profile_permission", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    public string? Action
    {
        get => GetProperty<TerraformLiteralProperty<string>>("action")?.Value;
        set => this.WithProperty("action", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The principal attribute.
    /// </summary>
    public string? Principal
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal")?.Value;
        set => this.WithProperty("principal", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    public string? ProfileName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("profile_name")?.Value;
        set => this.WithProperty("profile_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The profile_version attribute.
    /// </summary>
    public string? ProfileVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("profile_version")?.Value;
        set => this.WithProperty("profile_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The statement_id attribute.
    /// </summary>
    public string? StatementId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("statement_id")?.Value;
        set => this.WithProperty("statement_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The statement_id_prefix attribute.
    /// </summary>
    public string? StatementIdPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("statement_id_prefix")?.Value;
        set => this.WithProperty("statement_id_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
