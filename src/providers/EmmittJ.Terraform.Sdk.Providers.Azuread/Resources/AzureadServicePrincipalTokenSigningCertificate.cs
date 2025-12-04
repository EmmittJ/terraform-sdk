using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadServicePrincipalTokenSigningCertificate.
/// Nesting mode: single
/// </summary>
public class AzureadServicePrincipalTokenSigningCertificateTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azuread_service_principal_token_signing_certificate Terraform resource.
/// Manages a azuread_service_principal_token_signing_certificate resource.
/// </summary>
public partial class AzureadServicePrincipalTokenSigningCertificate(string name) : TerraformResource("azuread_service_principal_token_signing_certificate", name)
{
    /// <summary>
    /// A friendly name for the certificate
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The end date until which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). Default is 3 years from current date.
    /// </summary>
    public TerraformValue<string>? EndDate
    {
        get => GetArgument<TerraformValue<string>>("end_date");
        set => SetArgument("end_date", value);
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
    /// The ID of the service principal for which this certificate should be created
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalId is required")]
    public required TerraformValue<string> ServicePrincipalId
    {
        get => GetArgument<TerraformValue<string>>("service_principal_id");
        set => SetArgument("service_principal_id", value);
    }

    /// <summary>
    /// A UUID used to uniquely identify the verify certificate.
    /// </summary>
    public TerraformValue<string> KeyId
        => AsReference("key_id");

    /// <summary>
    /// The start date from which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`).
    /// </summary>
    public TerraformValue<string> StartDate
        => AsReference("start_date");

    /// <summary>
    /// The thumbprint of the certificate.
    /// </summary>
    public TerraformValue<string> Thumbprint
        => AsReference("thumbprint");

    /// <summary>
    /// The certificate data, which is PEM encoded but does not include the header/footer
    /// </summary>
    public TerraformValue<string> Value
        => AsReference("value");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadServicePrincipalTokenSigningCertificateTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadServicePrincipalTokenSigningCertificateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
