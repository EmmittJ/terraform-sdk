using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_service_specific_credential Terraform resource.
/// Manages a aws_iam_service_specific_credential resource.
/// </summary>
public partial class AwsIamServiceSpecificCredential(string name) : TerraformResource("aws_iam_service_specific_credential", name)
{
    /// <summary>
    /// The credential_age_days attribute.
    /// </summary>
    public TerraformValue<double>? CredentialAgeDays
    {
        get => GetArgument<TerraformValue<double>>("credential_age_days");
        set => SetArgument("credential_age_days", value);
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
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformValue<string> ServiceName
    {
        get => GetArgument<TerraformValue<string>>("service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformValue<string> UserName
    {
        get => GetArgument<TerraformValue<string>>("user_name");
        set => SetArgument("user_name", value);
    }

    /// <summary>
    /// The create_date attribute.
    /// </summary>
    public TerraformValue<string> CreateDate
        => AsReference("create_date");

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformValue<string> ExpirationDate
        => AsReference("expiration_date");

    /// <summary>
    /// The service_credential_alias attribute.
    /// </summary>
    public TerraformValue<string> ServiceCredentialAlias
        => AsReference("service_credential_alias");

    /// <summary>
    /// The service_credential_secret attribute.
    /// </summary>
    public TerraformValue<string> ServiceCredentialSecret
        => AsReference("service_credential_secret");

    /// <summary>
    /// The service_password attribute.
    /// </summary>
    public TerraformValue<string> ServicePassword
        => AsReference("service_password");

    /// <summary>
    /// The service_specific_credential_id attribute.
    /// </summary>
    public TerraformValue<string> ServiceSpecificCredentialId
        => AsReference("service_specific_credential_id");

    /// <summary>
    /// The service_user_name attribute.
    /// </summary>
    public TerraformValue<string> ServiceUserName
        => AsReference("service_user_name");

}
