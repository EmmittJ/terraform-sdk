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
        SetOutput("arn");
        SetOutput("profile_id");
        SetOutput("as2_id");
        SetOutput("certificate_ids");
        SetOutput("id");
        SetOutput("profile_type");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The as2_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "As2Id is required")]
    public required TerraformProperty<string> As2Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("as2_id");
        set => SetProperty("as2_id", value);
    }

    /// <summary>
    /// The certificate_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> CertificateIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("certificate_ids");
        set => SetProperty("certificate_ids", value);
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
    /// The profile_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileType is required")]
    public required TerraformProperty<string> ProfileType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("profile_type");
        set => SetProperty("profile_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The profile_id attribute.
    /// </summary>
    public TerraformExpression ProfileId => this["profile_id"];

}
