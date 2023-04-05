الگوریتم تشخیص وجود دور
الگوریتم CycleDetect
در این الگوریتم از روش جستجوی اول عمق استفاده شده است. ابتدا تمام گره ها برچسب white می گیرند. سپس هر گرهی که مشاهده می شود برچسب gray می گیرد و زمانی که تمام فرزندانش مشاهده شدند برچسب black می گیرد. اگر در حین جستجو به یک گره با برچسب gray رسیدیم، به این معنی است که در گراف دور وجود دارد. زمان اجرای الگوریتم تشخیص دور در گراف برابر با زمان اجرای الگوریتم جستجوی اول عمق است یعنی V+E است.

کد: 
boolean cycleDetect(Graph g)
    for each vertex v in g do
        v.mark = WHITE
    end for
    for each vertex v in g do
        if v.mark == WHITE then
            if visit(g, v) then
                return TRUE
            end if
        end if
    end for
    return FALSE;

boolean visit(Graph g, Vertex v)
    v.mark = GREY
    for each edge (v, u) in g do
        if u.mark == GREY then
            return TRUE
        else if u.mark == WHITE then
            if visit(g, u) then
                return TRUE
            end if
        end if
    end for
v.mark = BLACK
return FALSE