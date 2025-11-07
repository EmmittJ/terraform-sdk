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
    public TerraformLiteralProperty<string>? As2Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("as2_id");
        set => this.WithProperty("as2_id", value);
    }

    /// <summary>
    /// The certificate_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? CertificateIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("certificate_ids");
        set => this.WithProperty("certificate_ids", value);
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
    /// The profile_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProfileType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("profile_type");
        set => this.WithProperty("profile_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The profile_id attribute.
    /// </summary>
    public TerraformExpression ProfileId => this["profile_id"];

}
