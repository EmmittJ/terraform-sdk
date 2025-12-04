using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_s3control_access_grants_location Terraform resource.
/// Manages a aws_s3control_access_grants_location resource.
/// </summary>
public partial class AwsS3controlAccessGrantsLocation(string name) : TerraformResource("aws_s3control_access_grants_location", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string>? AccountId
    {
        get => GetArgument<TerraformValue<string>>("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleArn is required")]
    public required TerraformValue<string> IamRoleArn
    {
        get => GetArgument<TerraformValue<string>>("iam_role_arn");
        set => SetArgument("iam_role_arn", value);
    }

    /// <summary>
    /// The location_scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationScope is required")]
    public required TerraformValue<string> LocationScope
    {
        get => GetArgument<TerraformValue<string>>("location_scope");
        set => SetArgument("location_scope", value);
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
    /// The access_grants_location_arn attribute.
    /// </summary>
    public TerraformValue<string> AccessGrantsLocationArn
        => AsReference("access_grants_location_arn");

    /// <summary>
    /// The access_grants_location_id attribute.
    /// </summary>
    public TerraformValue<string> AccessGrantsLocationId
        => AsReference("access_grants_location_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

}
