using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadApplicationCertificate.
/// Nesting mode: single
/// </summary>
public class AzureadApplicationCertificateTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azuread_application_certificate Terraform resource.
/// Manages a azuread_application_certificate resource.
/// </summary>
public partial class AzureadApplicationCertificate(string name) : TerraformResource("azuread_application_certificate", name)
{
    /// <summary>
    /// The resource ID of the application for which this certificate should be created
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformValue<string> ApplicationId
    {
        get => new TerraformReference<string>(this, "application_id");
        set => SetArgument("application_id", value);
    }

    /// <summary>
    /// Specifies the encoding used for the supplied certificate data
    /// </summary>
    public TerraformValue<string>? Encoding
    {
        get => new TerraformReference<string>(this, "encoding");
        set => SetArgument("encoding", value);
    }

    /// <summary>
    /// The end date until which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). If omitted, the API will decide a suitable expiry date, which is typically around 2 years from the start date
    /// </summary>
    public TerraformValue<string> EndDate
    {
        get => new TerraformReference<string>(this, "end_date");
        set => SetArgument("end_date", value);
    }

    /// <summary>
    /// A relative duration for which the certificate is valid until, for example `240h` (10 days) or `2400h30m`
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? EndDateRelative
    {
        get => new TerraformReference<string>(this, "end_date_relative");
        set => SetArgument("end_date_relative", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// A UUID used to uniquely identify this certificate. If omitted, a random UUID will be automatically generated
    /// </summary>
    public TerraformValue<string> KeyId
    {
        get => new TerraformReference<string>(this, "key_id");
        set => SetArgument("key_id", value);
    }

    /// <summary>
    /// The start date from which the certificate is valid, formatted as an RFC3339 date string (e.g. `2018-01-01T01:02:03Z`). If this isn&#39;t specified, the current date and time are use
    /// </summary>
    public TerraformValue<string> StartDate
    {
        get => new TerraformReference<string>(this, "start_date");
        set => SetArgument("start_date", value);
    }

    /// <summary>
    /// The type of key/certificate
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The certificate data, which can be PEM encoded, base64 encoded DER or hexadecimal encoded DER. See also the `encoding` argument
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadApplicationCertificateTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadApplicationCertificateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
