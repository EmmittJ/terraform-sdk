using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_transfer_profile Terraform resource.
/// Manages a aws_transfer_profile resource.
/// </summary>
public partial class AwsTransferProfile(string name) : TerraformResource("aws_transfer_profile", name)
{
    /// <summary>
    /// The as2_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "As2Id is required")]
    public required TerraformValue<string> As2Id
    {
        get => GetArgument<TerraformValue<string>>("as2_id");
        set => SetArgument("as2_id", value);
    }

    /// <summary>
    /// The certificate_ids attribute.
    /// </summary>
    public TerraformSet<string>? CertificateIds
    {
        get => GetArgument<TerraformSet<string>>("certificate_ids");
        set => SetArgument("certificate_ids", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The profile_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileType is required")]
    public required TerraformValue<string> ProfileType
    {
        get => GetArgument<TerraformValue<string>>("profile_type");
        set => SetArgument("profile_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The profile_id attribute.
    /// </summary>
    public TerraformValue<string> ProfileId
        => AsReference("profile_id");

}
