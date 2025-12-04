using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleApigeeKeystoresAliasesPkcs12.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeKeystoresAliasesPkcs12TimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_apigee_keystores_aliases_pkcs12 Terraform resource.
/// Manages a google_apigee_keystores_aliases_pkcs12 resource.
/// </summary>
public partial class GoogleApigeeKeystoresAliasesPkcs12(string name) : TerraformResource("google_apigee_keystores_aliases_pkcs12", name)
{
    /// <summary>
    /// Alias Name
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Alias is required")]
    public required TerraformValue<string> Alias
    {
        get => GetArgument<TerraformValue<string>>("alias");
        set => SetArgument("alias", value);
    }

    /// <summary>
    /// Environment associated with the alias
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    public required TerraformValue<string> Environment
    {
        get => GetArgument<TerraformValue<string>>("environment");
        set => SetArgument("environment", value);
    }

    /// <summary>
    /// Cert content
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "File is required")]
    public required TerraformValue<string> File
    {
        get => GetArgument<TerraformValue<string>>("file");
        set => SetArgument("file", value);
    }

    /// <summary>
    /// Hash of the pkcs file
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filehash is required")]
    public required TerraformValue<string> Filehash
    {
        get => GetArgument<TerraformValue<string>>("filehash");
        set => SetArgument("filehash", value);
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
    /// Keystore Name
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Keystore is required")]
    public required TerraformValue<string> Keystore
    {
        get => GetArgument<TerraformValue<string>>("keystore");
        set => SetArgument("keystore", value);
    }

    /// <summary>
    /// Organization ID associated with the alias
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformValue<string> OrgId
    {
        get => GetArgument<TerraformValue<string>>("org_id");
        set => SetArgument("org_id", value);
    }

    /// <summary>
    /// Password for the Private Key if it&#39;s encrypted
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// Chain of certificates under this alias.
    /// </summary>
    public TerraformList<TerraformMap<object>> CertsInfo
        => AsReference("certs_info");

    /// <summary>
    /// Optional.Type of Alias
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeKeystoresAliasesPkcs12TimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeKeystoresAliasesPkcs12TimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
