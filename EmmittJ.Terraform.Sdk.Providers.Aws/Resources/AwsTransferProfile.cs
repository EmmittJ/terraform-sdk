using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_transfer_profile resource.
/// </summary>
public class AwsTransferProfile : TerraformResource
{
    public AwsTransferProfile(string name) : base("aws_transfer_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("profile_id");
    }

    /// <summary>
    /// The as2_id attribute.
    /// </summary>
    public string? As2Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("as2_id")?.Value;
        set => this.WithProperty("as2_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_ids attribute.
    /// </summary>
    public HashSet<string>? CertificateIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("certificate_ids")?.Value;
        set => this.WithProperty("certificate_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The profile_type attribute.
    /// </summary>
    public string? ProfileType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("profile_type")?.Value;
        set => this.WithProperty("profile_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The profile_id attribute.
    /// </summary>
    public TerraformExpression ProfileId => this["profile_id"];

}
